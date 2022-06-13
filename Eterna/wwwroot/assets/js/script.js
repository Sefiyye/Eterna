$('.slider').slick({
    dots: true,
    infinite: true,
    speed: 500,
    fade: true,
    cssEase: 'linear',
    nextArrow: $(".nextBtn"),
    prevArrow: $(".prevBtn"),
    autoplay: true,
    autoplaySpeed: 2000,
})
$('.brands').slick({
    slidesToShow: 6,
    slidesToScroll: 1,
    dots: true,
})


