$(document).ready(function() {
  var currentPath = window.location.pathname;

    if (currentPath === '/Shop' || currentPath === '/' || currentPath === '/About' || currentPath === '/News') {
        $('.menu__user a.menu__user--cart').removeClass('isMain');
        $('.menu__nav ul li a').removeClass('isMain');
        $('.menu__nav ul li a[href="' + currentPath + '"]').addClass('isMain');
    }
    if (currentPath === '/Cart') {
        $('.menu__nav ul li a').removeClass('isMain');
        $('.menu__user a.menu__user--cart').addClass('isMain');
    }
});
