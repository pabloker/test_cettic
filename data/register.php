<?php

  require_once('../config/config.php');

  $username = $_POST["usernamePost"];
  $password = $_POST["passwordPost"];

  $sql = "INSERT INTO Users (username, password) VALUES ('".$username."', '".$password."')";
  $sql2 = "SELECT * FROM Users WHERE username = '".$username."' ";

  $result2 = mysqli_query($conn, $sql2);

  if(mysqli_num_rows($result2) > 0){
    while($row = mysqli_fetch_assoc($result2)){
      if($row['username'] == $username){
        echo "User already exists";
      }
    }
  }
  elseif($username == "")
  {
    echo "Username shouldn't be empty";
  }
   elseif($password == "")
  {
    echo "Password shouldn't be empty";
  }
  else
  {
    echo "user created";
    $result = mysqli_query($conn, $sql);
  }

?>
