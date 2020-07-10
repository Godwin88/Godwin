
<?php
$db = mysqli_connect("localhost", "root", "", "attendance");

$errors = array(); 

if (isset($_POST['login'])) {
  $username = mysqli_real_escape_string($db, $_POST['email']);
  $password = mysqli_real_escape_string($db, $_POST['password']);
  
  

  if (count($errors) == 0) {
  	
  	$query = "SELECT * FROM teacher WHERE email='$username' AND password='$password'";
  	$results = mysqli_query($db, $query);
  	if (mysqli_num_rows($results) == 1) {
  	  $_SESSION['username'] = $username;
  	  $_SESSION['success'] = "You are now logged in";
  	  header('location: class.php');
  	}else {
  		echo "<script>window.alert('WRONG USERNAME OR PASSWORD COMBINATION');window.location='index.php';</script>";
  	}
  }
}
?>

<?php
$db = mysqli_connect("localhost", "root", "", "attendance");

$errors = array(); 

if (isset($_POST['register'])) {
  $name =     $_POST['name'];
  $username = $_POST['email'];
  $password = $_POST['password'];
  $date = date("y/m/d -||- h:isa");
  


  if (count($errors) == 0) {
  	
  	$query = "INSERT INTO  teacher (name, email, password, date) VALUES ('$name','$username','$password', '$date')";
  	$results = mysqli_query($db, $query);
  	if (mysqli_num_rows($results) == 1) {
  	  $_SESSION['username'] = $username;
  	  $_SESSION['success'] = "You are now Registerd";
  	  header('location: class.php');
  	}else {
  		echo "<script>window.alert('Registerd ');window.location='index.php';</script>";
  	}
  }
}
?>

