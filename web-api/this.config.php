<?php
error_reporting(0);
require_once "../system/config.php";
require_once '../system/class/ProtectClass.php';

$q1 = mysqli_query($db, "select * from api_server where 1");
$s = mysqli_fetch_array($q1);

$password = "vynghia@1308"; // this.password.api
