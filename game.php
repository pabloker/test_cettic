<!DOCTYPE html>
<html lang="en-us">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>cettic_test</title>
    <link rel="stylesheet" href="css/style.css">
    <script type="text/javascript" src = "js/jquery.min.js"></script>
  </head>
  <body>

    <div id='cssmenu'>
      <ul>
         <li><a href='index.php'>Settings</a></li>
         <li><a href='charts.php'>Metrics</a></li>
      </ul>
    </div>
    <?php
    echo "Timer: {$_POST['formTimer']} <br>";
    echo "Points: {$_POST['formPoints']} <br>";
    echo "Player Speed: {$_POST['formSpeed']}";
    ?>
  </body>
</html>
<?php
  require_once('config/config.php');

  $maketemp = "CREATE TABLE temp_table_1 (timer VARCHAR(100) PRIMARY KEY, pointbyrice VARCHAR(100), playerspeed VARCHAR(100))";
  mysqli_query($conn, $maketemp);


  $inserttemp = "INSERT INTO temp_table_1 (timer, pointbyrice, playerspeed ) VALUES ('".$_POST['formTimer'].".', '".$_POST['formPoints'].".', '".$_POST['formSpeed']."')";

  if($_POST['formTimer'] != "" && $_POST['formPoints'] != "" && $_POST['formSpeed'] != ""){
   mysqli_query($conn, $inserttemp);
  }
?>

