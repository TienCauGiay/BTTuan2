$(".product-item").click(function(e) {
    e.preventDefault();
    var productName = $(this).find("h5").text();
    window.location.href = "/Images/" + productName;
  });
  