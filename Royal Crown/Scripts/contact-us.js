/*
	Project Name :roofcare
	Author Company : Ewebcraft
	Project Date: 26 august, 2015
	Author Website : http://www.ewebcraft.com
	Author Email : ewebcraft@gmail.com
*/
$(window).load(function(){
 $('#loader').fadeOut("slow");
});

/*  toggle button*/
$(".slicknav_btn").on('click', function(e){
  $(".slicknav").toggleClass("mobile-nav");
});



/*header fixed*/
$(document).ready(function() {
  var $header = $(".jx-header"),
      $clone = $header.before($header.clone().addClass("clone"));

  $(window).on("scroll", function() {
    var fromTop = $("body").scrollTop();
    $('body').toggleClass("down", (fromTop > 200));
  });

      /* Map */

      function initialize() {
            var mapCanvas = document.getElementById('map-canvas');
            var mapOptions = {
              center: new google.maps.LatLng(51.508742,-0.120850),
              zoom: 14,
              scrollwheel: false,
              mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            var map = new google.maps.Map(mapCanvas, mapOptions);
			 /*********Start Map Pin code******/
			  marker = new google.maps.Marker({
					map: map,
					title:"Roofers Contracters Theme",
					
					position: new google.maps.LatLng(51.508742,-0.120850)
					
				});
				infowindow = new google.maps.InfoWindow({
						content:"Address at World 220-B City State, Country" 
				});
				google.maps.event.addListener(marker, "click", function(){
					infowindow.open(map,marker);
				});
				/*********End Map Pin code******/
        }
         google.maps.event.addDomListener(window, 'load', initialize);

     /* Map */
});

