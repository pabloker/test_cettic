var lineGraph3;
$('document').ready(function(){

  $("#meetingPlace2").change(function(){

  var selecteduser = $(this).val();
   RequestUser2(selecteduser);

 });
function RequestUser2(username){
  $.ajax({
    method: "POST",
    url: "http://localhost/website/data/avgvsplayerdata.php",
    data: {selected2: username},
    success: function(data){
      console.log(data);
      var player = [];
      var avg = [];
      var score = [];

      for(var i in data){
        player.push("Gameplay "+ data[i].play);
        avg.push(data[i].average);
        score.push(data[i].totalscore);
      }

      var chardata = {

        labels: player,
        datasets : [
          {
            label: "average",
            fill: false,
            lineTension: 0.1,
            backgroundColor: "rgba(59, 89, 152, 0.75)",
            borderColor: "rgba(59, 89, 152, 1)",
            pointHoverBackgroundColor: "rgba(59, 89, 152, 1)",
            pointHoverBorderColor: "rgba(59, 89, 152, 1)",
            data: avg
          },
          {
            label: username + " score",
            fill: false,
            lineTension: 0.1,
            backgroundColor: "rgba(29, 202, 255, 0.75)",
            borderColor: "rgba(29, 202, 255, 1)",
            pointHoverBackgroundColor: "rgba(29, 202, 255, 1)",
            pointHoverBorderColor: "rgba(29, 202, 255, 1)",
            data: score
          }
        ]
      };
      if (lineGraph3 != undefined || lineGraph3 != null) {
         lineGraph3.destroy();
          }
      var ctx = $("#mycanvas3");
       lineGraph3 = new Chart(ctx, {
        type: 'line',
        data: chardata,
        options: {
              scales: {
                yAxes: [{
                 scaleLabel: {
                  display: true,
                  labelString: 'Score'
                  },
                  ticks: {
                    beginAtZero: true
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
}
});
