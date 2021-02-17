$(document).ready(function () {
   $("#refresh").click(function () {
       var selectedType = $('#checkBoxType').val();
       $('#people').load('/LoadWorkers?Role='+selectedType)
       return false;

                    });


            });


