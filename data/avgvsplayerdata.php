<?php

  header('Content-Type: application/json');

  require_once('../config/config.php');

  $query = sprintf("SELECT play, AVG(totalscore) as average from Sessions
           GROUP BY play");
  $result = $conn -> query($query);

  $data = array();
  foreach ($result as $row){
    $data[] = $row;
  }

  $json1=json_encode($data);

  $query = sprintf("SELECT t1.username, t2.totalscore FROM users AS t1
           INNER JOIN sessions AS t2 ON t1.user_ID = t2.users_fk
           WHERE username = '".$_POST['selected2']."' ");

  $result = $conn -> query($query);

  $data = array();
  foreach ($result as $row){
    $data[] = $row;
  }

  $json2=json_encode($data);

  foreach(json_decode($json2, true) as $key => $array){
  $data[$key] = array_merge(json_decode($json1, true)[$key],$array);
  }

  print json_encode($data);

  $result->close();
  $conn->close();

?>
