<?php

  require_once('../config/config.php');

  $user_username = $_POST["usernamePost"];
  $user_password = $_POST["passwordPost"];

  $sql = "SELECT * FROM Users WHERE username = '".$user_username."' ";
  $result = mysqli_query($conn, $sql);

  if(mysqli_num_rows($result) > 0){
    while($row = mysqli_fetch_assoc($result)){
    if($row['password'] == $user_password){
      echo "login success";

    }else {
      echo "password incorrect";
        }
      }
    }elseif($user_username == "")
  {
    echo "Username shouldn't be empty";
  }
   elseif($user_password == "")
  {
    echo "Password shouldn't be empty";
  }
    else{
        echo "user not found";
        }
?>
