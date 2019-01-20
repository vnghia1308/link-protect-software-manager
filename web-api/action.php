<?php
require("this.config.php");

if(!empty($_POST["session"]) && $_POST["session"] == $s["session_key"])
{
	if($_GET["do"] == "delete" && !empty($_POST["linkid"]))
	{
		if(isset($_POST['linkid']))
		{
			$link = new CreateLink;
			$link->deleteLink($db, $_POST['linkid']);
		}
	}
}