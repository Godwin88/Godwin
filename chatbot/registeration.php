<?php
session_start();
header('location:login.php');


$con = mysqli_connect("localhost", "root", "", "chatbot");

$name =$_POST['user'];
$pass =$_POST['password'];
$phone =$_POST['number'];
$mail =$_POST['email'];
$add =$_POST['address'];
$s = 	"SELECT * FROM user WHERE username = '$name'";

$result = mysqli_query($con, $s);

$num = mysqli_num_rows($result);

if($num ==1){
	echo" username already taken";
}else{
	$reg= " INSERT INTO user(username, password, phone, email, address) VALUES ('$name', '$pass', '$phone', '$mail', '$add')";
	mysqli_query($con, $reg);
	echo" Registration successful";
}




?>