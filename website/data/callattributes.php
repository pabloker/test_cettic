<?php

require_once('../config/config.php');

  $defaultValues = "30.1.90";
  $getvalues =  "SELECT timer, pointbyrice, playerspeed FROM temp_table_1 ORDER BY id DESC LIMIT 1";
  $result = mysqli_query($conn, $getvalues);

  if(mysqli_num_rows($result) > 0){
    while($row = mysqli_fetch_assoc($result)){

        echo $row['timer'];
        echo $row['pointbyrice'];
        echo $row['playerspeed'];

      }
    }
    else
    {
      echo $defaultValues;
    }
?>
