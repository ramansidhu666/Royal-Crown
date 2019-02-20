/*
  Project Name : roofcare
  Author Company : Ewebcraft
  Author Website : http://www.ewebcraft.com
  Author Email : ewebcraft@gmail.com
*/

(function($) {
  "use strict";	   

   

    $("#sponsers-slider").owlCarousel({
          navigation : true,
          navigationText: [
        "<i class='fa fa-chevron-left'></i>",
        "<i class='fa fa-chevron-right'></i>"],
          loop:true,
          autoplay:true,
          autoplayHoverPause:true,
          autoPlay: 3000, //Set AutoPlay to 3 seconds
          stopOnHover: true,
          items : 4,
          dots: false,
          pagination:false,
          itemsDesktop : [1199,3],
          itemsDesktopSmall : [979,3]
        });    
})(jQuery);
    

