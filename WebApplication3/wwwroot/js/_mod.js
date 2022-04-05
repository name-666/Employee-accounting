

function count_rabbits() {
    var I = 1;

    var d1 = document.getElementById('table');
    d1.insertAdjacentHTML('afterbegin', ` <class="form-control" required  id="validationCustom[${I}]" type="text" asp-for="Surname" placeholder="Фамилия">`);
    d1.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');

    var d2 = document.getElementById('table2');
    d2.insertAdjacentHTML('afterbegin', `<input class="form-control" required  id="validationCustom[${I}]" type="text" asp-for="Name" placeholder="Имя">`);
    d2.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');

    var d3 = document.getElementById('table3');
    d3.insertAdjacentHTML('afterbegin', ` <input class="form-control" required  id="validationCustom[${I}]" type="text" asp-for="Patronymic" placeholder="Отчество">`);
    d3.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');

    var d4 = document.getElementById('table4');

    d4.insertAdjacentHTML('afterbegin', `<select class="form-control" required  id="validationCustom[${I}]" asp-for="WorkingMode"><option  value="Office" selected="selected">Офис</option><option value="Remoute">Удаленка</option> <option value="Changle">Дежурство</option>`);
    d4.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');

    var d5 = document.getElementById('table5');
    d5.insertAdjacentHTML('afterbegin', `<input class="form-control" required  id="validationCustom[${I}]" type="text" asp-for="Position" placeholder="Должность">`);
    d5.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');
    I++;

}
