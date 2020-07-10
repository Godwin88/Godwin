<!DOCTYPE html>
<html>
<head>
	<title>Chatbot</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>

<?php


?>

<div class="container">
	<div class="container-boxer-one">
		<h2 class="h-two"> Chat One</h2>
		<div class="text-output">
			<?php
			//importing connection file
            include("datamanager/connection.php");
                $user_two = "computer 2";
				$user_one = "computer 1";
			if(isset($_POST['sub-two'])){
				
                $getoutput_two = validatetext($_POST['comment-two']);
            
            //handling date AND TIME
            $gettime = date("h:i:s");
            $getdate = date("d M, Y");
            //INSERTING INTO DATABASE
           $query_one = "INSERT INTO chats(time,date,comment,username) VALUES(?,?,?,?)";
            $insert = $con->prepare($query_one);
            $insert->bind_param("ssss",$gettime,$getdate,$getoutput_two,$user_one);
            $insert->execute();    
        }

        //Retrieving from database
        $countt = 0;
            	$select_query = "SELECT comment,username FROM chats ";

            	$select = $con->prepare($select_query);
            	$select->execute();
            	
            	$select->bind_result($getcomment,$u);
            	while($select->fetch()):
            		$countt++;
            	
            	if($u == $user_two){
            		echo "<b style='color:grey;'>".$u."</b> => ". $getcomment."<br>";	
            		}else{
            			echo "<b style='color:orange;'>".$u."</b> => ". $getcomment."<br>";
            		}

                endwhile;

        if($countt < 1){
                	echo "Welcome please type in the comment bar to start chatting";
                }
			?>
		</div>
		<form method="post" action="<?php htmlspecialchars(strip_tags(stripslashes($_SERVER['PHP_SELF'])));  ?>">
			<input type="text" name="comment-one" placeholder="type comment here">
			<input type="submit" name="sub-one" value="submit">
		</form>
	</div>


	<div class="container-boxer-two">
		<h2 class="h-two"> Chat Two</h2>
		<div class="text-output">
			<?php
		        $user_two = "computer 2";
				$user_one = "computer 1";
			if(isset($_POST['sub-one'])){
            	

            $getoutput_two = validatetext($_POST['comment-one']);
            //importing connection file
            
            //handling date AND TIME
            $gettime = date("h:i:s");
            $getdate = date("d M, Y");
            //INSERTING INTO DATABASE
           $query_one = "INSERT INTO chats(time,date,comment,username) VALUES(?,?,?,?)";
            $insert = $con->prepare($query_one);
            $insert->bind_param("ssss",$gettime,$getdate,$getoutput_two,$user_two);
            $insert->execute();
         }
         $count = 0;
         //Retrieving from database
            	$select_query = "SELECT comment,username FROM chats";

            	$select = $con->prepare($select_query);
            	$select->execute();
            	
            	$select->bind_result($getcomment,$u);
            	while($select->fetch()):
            		$count++;
            		if($u == $user_one){
            		echo "<b style='color:grey;'>".$u."</b> => ". $getcomment."<br>";	
            		}else{
            			echo "<b style='color:orange;'>".$u."</b> => ". $getcomment."<br>";
            		}
            	
                endwhile;
         

         if($count < 1){
                	echo "Welcome please type in the comment bar to start chatting";
                }
			?>
		</div>
		<form method="post" action="<?php htmlspecialchars(strip_tags(stripslashes($_SERVER['PHP_SELF'])));  ?>">
			<input type="text" name="comment-two" placeholder="type comment here">
			<input type="submit" name="sub-two" value="submit">
		</form>
	</div>


	<?php
  function validatetext($text){
   $gettext =  htmlspecialchars(strip_tags(stripslashes(trim($text))));
    return $gettext;
  }

	?>
</div>
</body>
</html>