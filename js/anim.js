var member = document.querySelectorAll('.member');

for (var i = 0; i < member.length; i++) {

  member[i].classList.add('wow');

};



var textarea = document.querySelector('.textarea-label');



var service = document.querySelectorAll('.service');

for (var i = 0; i < service.length; i++) {

  service[i].classList.add('wow');

};


if (Math.max(document.documentElement.clientWidth, document.body.clientWidth) > 1035) {

  var odd = document.querySelectorAll(".story:nth-child(2n-1)");

  var even = document.querySelectorAll(".story:nth-child(2n)");

  for (var i = 0; i < odd.length; i++) {

    odd[i].classList.add("wow");

    odd[i].classList.add("fadeInLeft");

  };

  for (var i = 0; i < even.length; i++) {

    even[i].classList.add("wow");

    even[i].classList.add("fadeInRight");

  };



  member[0].classList.add('fadeInLeft');

  member[1].classList.add('fadeInUp');

  member[2].classList.add('fadeInRight');



  service[0].classList.add('fadeInLeft')

  service[1].classList.add('fadeInUp')

  service[2].classList.add('fadeInRight')



  textarea.classList.add('fadeInRight');

} else {

  var stories = document.querySelectorAll(".story");

  for (var i = 0; i < stories.length; i++) {

    stories[i].classList.add("wow");

    stories[i].classList.add("fadeIn");

    stories[i].setAttribute("data-wow-duration", "1.5s");

  }



  member[0].classList.add('fadeInLeft');

  member[1].classList.add('fadeInRight');

  member[2].classList.add('fadeInUp');



  service[0].classList.add('fadeInLeft');

  service[1].classList.add('fadeInRight');

  service[2].classList.add('fadeInUp');



  textarea.classList.add('fadeInLeft');

}

