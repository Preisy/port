
var obj = {};
var section = document.getElementsByTagName('section');
var border = document.getElementById('active-border');
var li = document.querySelectorAll('.header li')

window.onscroll = function() {
  if (headerHeight >= (section[section.length - 1].getBoundingClientRect().top)) {
    var active = placeBorder(1)
  } else {
    for (var i = 2; i < section.length + 1; i++) {
      if (headerHeight >= (section[section.length - i].getBoundingClientRect().top)) {
        var active = placeBorder(i)
        break;
      }
    }
  }
}


function placeBorder(num) {
  var active = document.getElementsByClassName('active')[0]
  active.classList.remove('active');
  var active = li[li.length - num]
  active.classList.add('active');
  var left = 0
  for (let i = 0; i <= li.length - num; i++) {
    left += li[i].clientWidth
  }
  left -= active.clientWidth
  border.style.cssText = "width:" + active.clientWidth + "px;"
    + "left: " + left +"px;"
  return active;
}
