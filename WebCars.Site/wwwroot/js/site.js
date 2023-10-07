if (document.querySelectorAll('#filterEstoque').length > 0)
{
    const accordionButtonEstoque = document.getElementById("accordionFilterButton");
    const accordiontContentEstoque = document.getElementById("FilterContent");

    if (window.innerWidth <= 993) {
        accordiontContentEstoque.classList.remove("show");
    } else {
        accordiontContentEstoque.classList.add("show");
    } 
}