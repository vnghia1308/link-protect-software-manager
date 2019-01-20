<?php
require("this.config.php");

if(!empty($_POST["session"]) && $_POST["session"] == $s["session_key"])
{
	if(isset($_GET["list"]) && $_GET["list"] == "view")
	{
		$q2 = mysqli_query($db, "select * from link where 1 order by id desc");

		while($r = mysqli_fetch_array($q2))
		{
		   $ar[] = $r;
		}

		echo json_encode($ar);
	}
	else
	{
		if(isset($_POST['link']))
		{	
			$qr = mysqli_query($db, "select * from options");
			$op = mysqli_fetch_array($qr);

			//$user = new Protect;
			//$user->getUserInfo($_SESSION['facebook_access_token']);

			$EncodeLink = PseudoCrypt::hash(time(), 10);
			$LockedLink = WEBURL.'/x/'.$EncodeLink;
			$HashLink = '#protect@'.$EncodeLink.'@';
			
			$link = new CreateLink;
			
			if($op["google_short_link"] == 1)
			{
				$link->setGoogleApiKey($GoogleApiKey);

				$GoogleShortUrl = $link->getShortenedLink($LockedLink);
				
				$LinkProtect = $GoogleShortUrl;
			}
			else
				$LinkProtect = $LockedLink;
			
			$link->insertLink($db, $_POST["userid"], $EncodeLink, $_POST['target'], $_POST['pass'], $_POST['link'], $LinkProtect, date("Y-m-d H:i:s"));
			
			echo $LinkProtect.' | '.$HashLink;
		}
	}
}


