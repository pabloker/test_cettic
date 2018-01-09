<!DOCTYPE html>
  <head>
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/style.css">
    <title>Dashboard</title>
      </head>
        <body>
          <div id='cssmenu'>
          <ul>
             <li ><a href='index.php'>Settings</a></li>
             <li class='active'><a href='charts.php'>Metrics</a></li>
          </ul>
          </div>
          <div class="center">

          <h1>Average Score Chart</h1>
            <?php
              require_once('config/config.php');
              $sql = "SELECT DISTINCT(t1.username) FROM users AS t1 INNER JOIN
                      sessions AS t2 ON t1.user_ID = t2.users_fk";
              $result = mysqli_query($conn,$sql);
              if(mysqli_num_rows($result) > 0){
                echo "<div id = 'chart-container'>";
                echo  "<canvas id = 'mycanvas2'></canvas></div>";
              }else{
                echo "<h3>NO DATA</h3>";
              }
           ?>
          <h1>Average VS PlayerScore Chart</h1>
            <?php
              require_once('config/config.php');
              $sql = "SELECT DISTINCT(t1.username) FROM users AS t1 INNER JOIN
                      sessions AS t2 ON t1.user_ID = t2.users_fk";
              $result = mysqli_query($conn,$sql);

              if(mysqli_num_rows($result) > 0){
                echo "<div class='specialtext'>Choose Player: </div>";
                echo "<select class='select' id ='meetingPlace2'>";
                echo "<option value=''disabled selected>Select player</option>";
                while ($row = mysqli_fetch_array($result)) {
                  echo "<option value='".$row['username']."'>
                       ".$row['username']."</option>";
                }
                echo "</select>";
                echo "<div id = 'chart-container' class ='center'>";
                echo "<canvas id = 'mycanvas3'></canvas></div>";
              }else{
                echo "<h3>NO DATA</h3>";
              }
            ?>

          <h1>Score by Player</h1>
            <?php
              require_once('config/config.php');
              $sql = "SELECT DISTINCT(t1.username) FROM users AS t1 INNER JOIN
                      sessions AS t2 ON t1.user_ID = t2.users_fk";
              $result = mysqli_query($conn,$sql);
              if(mysqli_num_rows($result) > 0){
                 echo "<div class='specialtext'>Choose Player: </div>";
                echo "<select id ='meetingPlace'>";
                echo "<option value=''disabled selected>Select player</option>";
                while ($row = mysqli_fetch_array($result)) {
                  echo "<option value='" . $row['username'] ."'>
                  ".$row['username']."</option>";
                }
                echo "</select>";
                echo "<div id = 'chart-container'>";
                echo "<canvas id = 'mycanvas'></canvas></div>";
              }else{
                echo "<h3>NO DATA</h3>";
              }
            ?>
          </div>

          <script type="text/javascript" src = "js/jquery.min.js"></script>
          <script type="text/javascript" src = "js/chart.min.js"></script>
          <script type="text/javascript" src = "js/app.js"></script>
          <script type="text/javascript" src = "js/app2.js"></script>
          <script type="text/javascript" src = "js/app3.js"></script>

        </body>
</html>
