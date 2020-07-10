<?php
session_start();
if(isset($_SESSION['username'])){
	}

?>



<!DOCTYPE html>
<html>
<head>
	<title>homepage</title>

</head>
<body>
	<div class="container">
	<a class="float-right" href="logout.php"> logout </a>

<h1>welcome <?php echo $_SESSION['username']; ?> </h1>
</div>

</body>
</html>