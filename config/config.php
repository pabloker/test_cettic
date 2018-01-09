<?php

  $servername = "localhost";
  $usernameDB = "root";
  $passwordDB = "";
  $dbName = "runner";

  $conn = mysqli_connect($servername, $usernameDB, $passwordDB, $dbName);
  if(!$conn){
    die("Connection Failed. ".mysqli_connect_error());

  }
?>
