	(function () {
  'use strict'

  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  var forms = document.querySelectorAll('.needs-validation')

  // Loop over them and prevent submission
  Array.prototype.slice.call(forms)
    .forEach(function (form) {
      form.addEventListener('submit', function (event) {
        if (!form.checkValidity()) {
          event.preventDefault()
          event.stopPropagation()
        }

        form.classList.add('was-validated')
      }, false)
    })
})()



    function count_rabbits() {
            var I = 1;
    var d1 = document.getElementById('table');
    d1.insertAdjacentHTML('afterbegin', ` <input class="form-control" required  id="validationCustom" type="text" name="Surname" placeholder="Фамилия">`);
    d1.insertAdjacentHTML('afterbegin', '<span class="focus"></span>');

    var d2 = document.getElementById('table2');
    d2.insertAdjacentHTML('afterbegin', `<input class="form-control" required  id="validationCustom" type="text" name="Name" placeholder="Имя">`);
    d2.insertAdjacentHTML('afterbegin', '<span class="focus"></span>');

    var d3 = document.getElementById('table3');
    d3.insertAdjacentHTML('afterbegin', ` <input class="form-control" required  id="validationCustom" type="text" name="Patronymic" placeholder="Отчество">`);
    d3.insertAdjacentHTML('afterbegin', '<span class="focus"></span>');

    var d4 = document.getElementById('table4');

    d4.insertAdjacentHTML('afterbegin', `<select class="form-control"  id="validationCustom" name="WorkingMode"><option  value="Office" selected="selected">Офис</option><option value="Remoute">Удаленка</option> <option value="Changle">Дежурство</option>`);
    d4.insertAdjacentHTML('afterbegin', '<span class="focus"></span>');

    var d5 = document.getElementById('table5');
    d5.insertAdjacentHTML('afterbegin', `<input class="form-control" required  id="validationCustom" type="text" name="Position" placeholder="Должность">`);
    d5.insertAdjacentHTML('afterbegin', '<span class="focus"></span>');

I++
 }
