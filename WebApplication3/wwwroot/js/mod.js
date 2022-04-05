

    function count_rabbits() {
            var I = 1;
    var d1 = document.getElementById('table');
    d1.insertAdjacentHTML('afterbegin', ' <div class="wrap-input100>');
        d1.insertAdjacentHTML('afterbegin', ` <input id="input100" class="input100" type="text" name="Surname[${I}]" placeholder="Фамилия">`);
            d1.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');



            var d2 = document.getElementById('table2');
            d2.insertAdjacentHTML('afterbegin', '<div class="wrap-input100>');
                d2.insertAdjacentHTML('afterbegin', ' <input class="input100" type="text" name="Name" placeholder="Имя">');
                    d2.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');


                    var d3 = document.getElementById('table3');
                    d3.insertAdjacentHTML('afterbegin', '<div class="wrap-input100>');
                        d3.insertAdjacentHTML('afterbegin', ' <input class="input100" type="text" name="Patronymic" placeholder="Отчество">');
                            d3.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');



  var d4 = document.getElementById('table4');
  d4.insertAdjacentHTML('afterbegin', '<select class="input100" name="WorkingMode"><option  selected="selected">Офис</option><option value="Чебурашка">Удаленка</option><option value="Шапокляк">дежурство</option>');



                                    d4.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');

                                    var d5 = document.getElementById('table5');
                                    d5.insertAdjacentHTML('afterbegin', '<div class="wrap-input100>');
                                        d5.insertAdjacentHTML('afterbegin', ' <input class="input100" type="text" name="Position" placeholder="Должность">');
                                            d5.insertAdjacentHTML('afterbegin', '<span class="focus-input100"></span>');


                                            c++;

      }
