<?php

  header('Content-Type: application/json');

  require_once('../config/config.php');

  $query = sprintf("SELECT t1.username, t2.totalscore FROM users AS t1
           INNER JOIN sessions AS t2 ON t1.user_ID = t2.users_fk
           WHERE username = '".$_POST['selected']."' ");

  $result = $conn -> query($query);
  $data = array();

  foreach ($result as $row){
    $data[] = $row;
  }

  print json_encode($data);

  $result->close();
  $conn->close();
?>
