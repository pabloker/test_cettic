<?php

  header('Content-Type: application/json');

  require_once('../config/config.php');

  $query = sprintf("SELECT play, AVG(totalscore) as average from Sessions GROUP BY play");
  $result = $conn -> query($query);

  $data = array();

  foreach ($result as $row){
    $data[] = $row;
  }

  print json_encode($data);

  $result->close();
  $conn->close();
?>
