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
             <li ><a href="index.php">Settings</a></li>
             <li class='active'><a href="charts.php">Metrics</a></li>
          </ul>
          </div>
          <div class="center">

          <h1>Average Score Chart</h1>
            <div id = 'chart-container'>
            <canvas id = 'mycanvas1'></canvas></div>

          <h1>Average VS PlayerScore Chart</h1>
            <div id = 'chart-container'>
            <canvas id = 'mycanvas2'></canvas></div>

          <h1>Score by Player</h1>
            <div id = 'chart-container'>
            <canvas id = 'mycanvas3'></canvas></div>

          </div>

          <script type="text/javascript" src = "js/jquery.min.js"></script>
          <script type="text/javascript" src = "js/chart.min.js"></script>
          <script type="text/javascript" src = "js/appcanvas1.js"></script>
          <script type="text/javascript" src = "js/appcanvas2.js"></script>
          <script type="text/javascript" src = "js/appcanvas3.js"></script>

        </body>
</html>
