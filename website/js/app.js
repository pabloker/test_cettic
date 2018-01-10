var barGraph;
$('document').ready(function(){

$("#meetingPlace").change(function(){

  var selecteduser = $(this).val();
   RequestUser(selecteduser);

 });

  function RequestUser(username){
  $.ajax({
    method: "POST",
    url: "http://localhost/runner/dao/playerdata.php",
    data: {selected: username},
    success: function(data){
      console.log(data);
      var player = [];
      var score = [];
      var count = 0;

      for(var i in data){
        count = count + 1;
        player.push("Gameplay "+ count);
        score.push(data[i].totalscore);
      }

      var chardata = {

        labels: player,
        datasets : [
          {
            label: username +' Score',
            backgroundColor: 'rgba(200, 250, 200, 0.75)',
            borderColor: 'rgba(200, 200, 200, 0.75)',
            hoverBackgroundColor: 'rgba(200, 200, 250, 1)',
            hoverBorderColor: 'rgba(200, 200, 200, 1)',
            data: score
          }
        ]
      };
      if (barGraph != undefined || barGraph != null) {
         barGraph.destroy();
          }
      var ctx = $("#mycanvas");
       barGraph = new Chart(ctx, {
        type: 'bar',
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
