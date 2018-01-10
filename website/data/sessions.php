<?php

  require_once('../config/config.php');

  $score = $_POST["UnityFinalScore"];
  $username = $_POST["UnityUser"];

  $sql2 = "SELECT * FROM Users WHERE username = '".$username."'";
  $sql3 = "SELECT play FROM Sessions WHERE users_fk = (SELECT user_ID
          FROM Users WHERE username = '".$username."')
          ORDER BY play DESC LIMIT 1";

  $result3 = mysqli_query($conn, $sql3);
  if(mysqli_num_rows($result3) > 0){
    while($row = mysqli_fetch_assoc($result3)){
        $currentPlay = $row['play']+1;
    }
  }else{
      $currentPlay = 1;
  }

  $sql = "INSERT INTO Sessions (play, totalscore, users_fk)
         VALUES ('".$currentPlay."','".$score."',
         (SELECT user_ID FROM Users WHERE username = '".$username."'))";

  $result2 = mysqli_query($conn, $sql2);
  if(mysqli_num_rows($result2) > 0){

    while($row = mysqli_fetch_assoc($result2)){
      if($row['username'] == $username){
        echo "Record saved";
        echo  $currentPlay;
        $result = mysqli_query($conn, $sql);
      }
    }
  }
?>
