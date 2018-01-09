<!doctype html>
  <html lang=''>
  <head>
     <meta charset='utf-8'>
     <meta http-equiv="X-UA-Compatible" content="IE=edge">
     <meta name="viewport" content="width=device-width, initial-scale=1">
     <link rel="stylesheet" href="css/style.css">
     <title>Settings</title>
  </head>
    <body id="body-settings">
      <div id='cssmenu'>
        <ul>
           <li class="active"><a href="index.php">Settings</a></li>
           <li><a href="charts.php">Metrics</a></li>
        </ul>
      </div>
      <table>
        <tr>
          <form action="" method="post">
            <td>Set Timer</td>
            <td><input type="number" name="formTimer" max="500" value="30"></td>
        </tr>
        <tr>
            <td>Set Points</td>
            <td><input type="number" name="formPoints" max="1000" value="1"></td>
        </tr>
        <tr>
            <td>Set Speed</td>
            <td><input type="number" name="formSpeed" max="200" value="90"></td>
        </tr>
        <tr>
            <td>
            <button align="right" class="button" name="submit" type="submit" value="PLAY">PLAY!</button>
            </td>
          </form>
        </tr>
      </table>

      <script type="text/javascript" src = "js/jquery.min.js"></script>
    </body>
  <html>
