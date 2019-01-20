<?php
/* >_ Developed by Vy Nghia */
session_start();
require("this.config.php");
require_once "../SDK/Facebook/autoload.php";

$qr = mysqli_query($db, "SELECT * FROM `web`");
$wb = mysqli_fetch_array($qr);

$q1 = mysqli_query($db, "select * from api_server where 1");
$s = mysqli_fetch_array($q1);

if(!empty($_GET["session"]) && $_GET["session"] == $s["session_key"])
{
	$fb = new Facebook\Facebook([
	  'app_id' => (string) $wb["fbappid"],
	  'app_secret' => (string) $wb["fbappsc"],
	  'default_graph_version' => 'v2.10',
	  ]);
	  

	$helper = $fb->getRedirectLoginHelper();
	$permissions = ['public_profile']; //optional

	try {
		if (isset($_SESSION['facebook_access_token'])) {
			$accessToken = $_SESSION['facebook_access_token'];
		} else {
			$accessToken = $helper->getAccessToken();
		}
	} catch(Facebook\Exceptions\FacebookResponseException $e) {
		// When Graph returns an error
		echo 'Graph returned an error: ' . $e->getMessage();

		exit;
	} catch(Facebook\Exceptions\FacebookSDKException $e) {
		// When validation fails or other local issues
		echo 'Facebook SDK returned an error: ' . $e->getMessage();
		;
	 }

	if (isset($accessToken)) 
	{
		if (isset($_SESSION['facebook_access_token'])) 
		{
			$fb->setDefaultAccessToken($_SESSION['facebook_access_token']);
		} else {
			// getting short-lived access token
			$_SESSION['facebook_access_token'] = (string) $accessToken;

			// OAuth 2.0 client handler
			$oAuth2Client = $fb->getOAuth2Client();

			// Exchanges a short-lived access token for a long-lived one
			$longLivedAccessToken = $oAuth2Client->getLongLivedAccessToken($_SESSION['facebook_access_token']);

			$_SESSION['facebook_access_token'] = (string) $longLivedAccessToken;

			// setting default access token to be used in script
			$fb->setDefaultAccessToken($_SESSION['facebook_access_token']);
		}

		if(isset($_GET["code"]))
			echo $accessToken;
		else
			echo true;
		
		
		// getting basic info about user
		try 
		{
			$profile_request = $fb->get('/me?fields=name,first_name,last_name,email');
			$profile = $profile_request->getGraphNode()->asArray();
		} catch(Facebook\Exceptions\FacebookResponseException $e) 
		{
			// When Graph returns an error
			session_destroy();
			// redirecting user back to app login page
			echo '<script>window.location = "'.$_SERVER['HTTP_REFERER'].'";</script>';
			exit;
		} catch(Facebook\Exceptions\FacebookSDKException $e) 
		{
			// When validation fails or other local issues
			echo 'Facebook SDK returned an error: ' . $e->getMessage();
			exit;
		}
	} 
	else 
	{
		$link = (isset($_SERVER['HTTPS']) && $_SERVER['HTTPS'] === 'on' ? "https" : "http") . "://" .  $_SERVER['HTTP_HOST'] . $_SERVER['PHP_SELF']; 
		$loginUrl = $helper->getLoginUrl($link .'?session=' . $s["session_key"], $permissions);
		header("Location: {$loginUrl}");
	}
}