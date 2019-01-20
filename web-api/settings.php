<?php
error_reporting(0);
require("this.config.php");

if(!empty($_POST["session"]) && $_POST["session"] == $s["session_key"])
{
	$q2 = mysqli_query($db, "select * from settings where 1");
	$v = mysqli_fetch_array($q2);
	
	$ar = array("page_id" =>  $v["page_id"]);
	
	echo json_encode($ar);
}


