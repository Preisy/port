var elem = document.getElementsByClassName('navigation')[0]
var img = document.querySelector('img[alt="mobile-menu"]');
img.addEventListener('click', function() {
  tent();
  if(elem.style.transform == "translateX(100%)") {
    elem.style.cssText = "transform: translateX(0);"
    return true
  } else if (elem.style.transform == "translateX(0px)") {
    elem.style.cssText = "transform: translateX(100%);"
    return true
  }
  elem.style.cssText = "transform: translateX(0);";
})
