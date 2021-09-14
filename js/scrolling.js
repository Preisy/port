var li = document.querySelectorAll('.header li');
for (let i = 0; i < li.length; i++) {
  li[i].addEventListener('click', function scroll() {
    var gbcr = section[i].getBoundingClientRect().top;
    var difference = section[i].getBoundingClientRect().top;
    let passed = 0;
    var scrollTop;

    if (difference == headerHeight || (/home/.test(section[i].classList) && difference == 0)) return false
    if (/home/.test(section[i].classList)) difference = difference - headerHeight;
    else difference = Math.round(difference - headerHeight);

    var interval = Math.ceil(difference / 10);
    var timer = setTimeout(function increase() {
      var gbcr = section[i].getBoundingClientRect().top;
      document.documentElement.scrollTop += interval;
      passed += interval;
      if (scrollTop == document.documentElement.scrollTop) return true;
      scrollTop = document.documentElement.scrollTop;

      if(Math.abs(passed) >= Math.abs(difference)) {
        if (scrollTop != 0)
        document.documentElement.scrollTop += difference - passed + 1;
      } else if (passed < difference && difference < 0) {
        document.documentElement.scrollTop += passed - difference + 1;
      } else {
        var timer = setTimeout(increase, 10)
      }
    }, 10)
  })
}
