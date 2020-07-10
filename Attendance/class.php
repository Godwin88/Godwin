<?php
  session_start();
  
?>
<?php include 'php/node_class.php'; ?>
<html>
 <head>
  <link rel="stylesheet" href="css/style.css"/>
  <title>Edit Class</title>
  <link rel="stylesheet" href="css/bootstrap.min.css">
  <link rel="stylesheet" href="css/bootstrap-theme.min.css">
  <script src="js/jquery.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/class.js"></script>
  <style>.form-control{display:inline-block !important; width: 185px !important; margin:5px !important;}.details{padding:5px 10px;margin-bottom:30px;border: 1px solid lightgrey;border-top: none;}}</style>
 </head>
 <body>
  <div id="header" class="clearfix">
    <h1>Delta State Polytechnic Ozoro</h1>
    <h3>Edit Class</h3>	
  </div>
  <nav class="navbar navbar-default" id="sub-menu">  
    <div class="navbar-header">    
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">      
        <span class="sr-only">Toggle navigation</span>      
        <span class="icon-bar"></span>      
        <span class="icon-bar"></span>      
        <span class="icon-bar"></span>    
      </button>  
    </div>  
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">    
      <ul class="nav navbar-nav navbar-left">      
        <li><a href="teacher.php">Home</a></li>
        <li><a href="profile.php">Profile</a></li>
        <li class="active"><a href="class.php">Classes</a></li>
        <li><a href="statistics.php">Statistics</a></li>
        <li><a href="logout.php">Logout</a></li>
      </ul>  
    </div>  
  </nav> 
  <div class="container">
    <h2> You can see details of your classes here. </h2>

  <table style="padding:100px; margin:100px;" cellspacing="10" cellpadding="10">

<tr>
<td>#</td>
<th>NAME</th>
<th>TIME</th>
<th>DATE</th>
</tr>  

<tr>
<td>1</td>
<td>Godwin</td>
<td>11:30 AM</td>
<td>11/12/19</td>
</tr>
<br>
<tr>
<td>2</td>
<td>Florence</td>
<td>1:30 AM</td>
<td>10/12/19</td>
</tr>
  </table>
  </div>
 </body>
</html>
