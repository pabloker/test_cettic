var lineGraph2;
$('document').ready(function(){
  $.ajax({
    method: "GET",
    url: "http://localhost/runner/dao/avgdata.php",
    success: function(data){
      console.log(data);
      var player = [];
      var score = [];
      for(var i in data){
        player.push("Gameplay "+ data[i].play);
        score.push(data[i].average);
      }

      var chardata = {
        labels: player,
        datasets : [
          {
            label:  ' Average Score',
            backgroundColor: 'rgba(200, 250, 200, 0.75)',
            borderColor: 'rgba(200, 200, 200, 0.75)',
            hoverBackgroundColor: 'rgba(200, 200, 250, 1)',
            hoverBorderColor: 'rgba(200, 200, 200, 1)',
            data: score
          }
        ]
      };
      if (lineGraph2 != undefined || lineGraph2 != null) {
         lineGraph2.destroy();
          }
      var ctx = $("#mycanvas2");
       lineGraph2 = new Chart(ctx, {
        type: 'line',
        data: chardata,
        options: {
              scales: {
               yAxes: [{
                  scaleLabel: {
                  display: true,
                  labelString: 'Score',
                  ticks: {
                    beginAtZero: true
                    }
                  }
                }],
              }
            }
      });
    },
    error: function(data){
      console.log(data);
    }

   });
});
