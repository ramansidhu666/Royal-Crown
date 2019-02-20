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
			 
	// pretty photo function call
				$(document).ready(function(){
                $("a[data-gal^='prettyPhoto']").prettyPhoto({
				hook: 'data-gal',
				social_tools:false
				});
               });
			   
			   
	/*testimonial-slider*/
 $(window).load(function() {
    $('.testimonial-slider').flexslider({
	slideshow: true,                //Boolean: Animate slider automatically
	slideshow: true,                //Boolean: Animate slider automatically
	slideshowSpeed: 4000,           //Integer: Set the speed of the slideshow cycling, in milliseconds
	animationDuration: 600,
	animation: "slide",
 });
  });

/*  toggle button*/
$(".slicknav_btn").on('click', function(e){
  $(".slicknav").toggleClass("mobile-nav");
});



/* siderbar-slider*/
 $(window).load(function() {
    $('.siderbar-slider').flexslider({
	slideshow: true,                //Boolean: Animate slider automatically               //Boolean: Animate slider automatically
	slideshowSpeed: 4000,           //Integer: Set the speed of the slideshow cycling, in milliseconds
	animationDuration: 600,
	animation: "slide",
 });
  });
  

/*count_number*/
	
	(function($) {
	"use strict";

  /*-------> Skills <-------*/
        
   function progress(percent, $element) {
      var begin = 0;
      var pos = -100; 
      var handle = setInterval(function() {
      
      var mySkill  = pos + begin;
      $element.find('.skill-img').css('bottom',mySkill + "%");
      begin++;
      $element.find('.counterr').html(begin);
      
      if (begin >= percent) {
        clearInterval(handle);
        handle = null;
      }
    }, 20);    
}
  /*-------> Skills <-------*/

  

  if($('#our-skills').length > 0){
    var $section = $("#our-skills");
    $(document).bind('scroll', function(ev) {
        var scrollOffset = $(document).scrollTop();
        var containerOffset = $section.offset().top - window.innerHeight;
        if (scrollOffset > containerOffset) {            
           progress(85, $('#skill-1'));
           progress(75, $('#skill-2'));
           progress(100, $('#skill-3'));
           progress(90, $('#skill-4'));
           // unbind event not to load scrolsl again
           $(document).unbind('scroll');
        }       
    });
  } 
    var executed = false;
    $('#our-success').waypoint(function() {
      if(!executed) {
        executed = true;
        progress(85, $('#success-counter-1'));
        progress(80, $('#success-counter-2'));
        progress(90, $('#success-counter-3'));
        progress(100, $('#success-counter-4'));  
      }
   
      
      },{
         offset: '50%',  // middle of the page
        //triggerOnce: true
     });  
  	

  	/* Mix-It-Up */

	$(".tabs-style-linebox nav li").click(function(){
		$(this).addClass('active');
		$(".tabs-style-linebox nav li").removeClass('active');
	});
	$('.gallery-photos-thumb').mixItUp();

    /* Mix-It-Up */

    /* Flip Services */

    $('.ser-hover').hover(function(){
      $(this).addClass('flip');
    },function(){
      $(this).removeClass('flip');
    });

    /* Flip Services */
    
	
})(jQuery);



   
/* Stat Counter */
function count($this){
	var current = parseInt($this.html(), 10);
	current = current + 1; /* Where 50 is increment */	
	$this.html(++current);
	if(current > $this.data('count')){
		$this.html($this.data('count'));
	} else {    
		setTimeout(function(){count($this)}, 50);
	}
}$().ready(function() {
		$=jQuery
       				if($(".form").length > 0)
			{
				$(".form").validate();	
			}
		 });
		 
		 

	/*scroldown smothly*/
// handle links with @href started with '#' only
$(document).on('click', 'a[href^="#"]', function(e) {
    // target element id
    var id = $(this).attr('href');

    // target element
    var $id = $(id);
    if ($id.length === 0) {
        return;
    }

    // prevent standard hash navigation (avoid blinking in IE)
    e.preventDefault();

    // top position relative to the document
    var pos = $(id).offset().top;

    // animated top scrolling
    $('body, html').animate({scrollTop: pos});
});


/*header fixed*/
$(document).ready(function() {
  var $header = $(".jx-header"),
      $clone = $header.before($header.clone().addClass("clone"));

  $(window).on("scroll", function() {
    var fromTop = $("body").scrollTop();
    $('body').toggleClass("down", (fromTop > 200));
  });

  if(screen.width <= 768) {
    $('.menu > .for-mobile a').on('click', function (e) {
        e.stopPropagation();
        $(this).parent().find('ul').first().toggleClass('hidden-menu');
    });
     $('.menu > .for-scnd-nav a').on('click', function (e) {
        e.stopPropagation();
        $(this).parent().find('ul').first().toggleClass('hidden-menu');
    });    
  }
});

