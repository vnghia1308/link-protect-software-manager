<?php
require("this.config.php");

if(!empty($_POST["password"]) && $password == $_POST["password"])
{
	$session = md5(time());
	mysqli_query($db, "UPDATE api_server SET session_key='{$session}'");
	
	echo json_encode(array("status" => true, "session" => $session));
}
else
{
	if(!empty($_GET["session"]))
	{
		$q = mysqli_query($db, "select * from api_server where 1");
		$s = mysqli_fetch_array($q);
		
		if($_GET["session"] == $s["session_key"])
			echo "true";
		else
			echo "false";
	}
}