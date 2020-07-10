<!DOCTYPE html>
<html>
<head>
	<title>login</title>
	<link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
</head>
<style>
	body{
		background: linear-gradient(rgba(0,0,50,0.5),rgba(0,50,0.5));
		background-size: cover;
		background-position: center;
	}
	.login-box{
		max-width: 700px;
		float: none;
		margin: 150px auto;
	}
	.login-left{
		background: rgba(211, 211, 211, 0.5);
		padding: 30px;
	}
	.login-right{
		background: #fff;
		padding: 30px;
	}
	.form-control{
		background-color: transparent !important;
	}
	



</style>
<body>
<div class="container">
	<div class="login-box">
	<div class="row">
		<div class="col-md-6 login-left">
			<h2>login here</h2>
			<form action="validation.php" method="post">
				<div class="form-group">
					<label>username</label>
					<input type="text" name="user" class="form-control" required>
				</div>
				<div class="form-group">
					<label>password</label>
					<input type="password" name="password" class="form-control" required>
				</div>
				<button type="submit" class="btn btn-primary"> Login </button>
			</form>
		</div>
		
	       <div class="col-md-6 login-right">
			<h2>register here</h2>
			<form action="registeration.php" method="post">
				<div class="form-group">
					<label>username</label>
					<input type="text" name="user" class="form-control" required>
				</div>
				<div class="form-group">
					<label>password</label>
					<input type="password" name="password" class="form-control" required>
				</div>
				<div class="form-group">
					<label>phone</label>
					<input type="number" name="number" class="form-control" required>
				</div>
				<div class="form-group">
					<label>email</label>
					<input type="text" name="email" class="form-control" required>
				</div>
				<div class="form-group">
					<label>address</label>
					<input type="text" name="address" class="form-control" required>
				</div>
				<button type="submit" class="btn btn-primary"> register </button>
			</form>
		</div>
	</div>
      
      





</div>
</div>


</body>
</html>