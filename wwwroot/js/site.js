(function () {
    var ul = document.querySelectorAll('text');
    for (var i = 0; i < ul.length; i++) {
        var span = document.createElement('span');
        span.className = 'drop';
        span.innerHTML = '+'; // картинки лучше выравниваются, т.к. символы на одном браузере ровно выглядят, на другом — чуть съезжают 
        ul[i].parentNode.insertBefore(span, ul[i]);
        span.onclick = function () {
            this.innerHTML = (this.innerHTML == '+' ? '−' : '+');
            this.className = (this.className == 'drop' ? 'drop dropM' : 'drop');
        }
    }
})();

(function () {
    var pt = document.querySelectorAll(".ProblemTitle");
    for (var i = 0; i < pt.length; i++) {
        var title = pt[i].innerHTML;
        pt[i].onclick = function () {
            document.getElementById("description").innerHTML = title + '<div>'+
               '<a href="Problem/Update">Изменить</a>'+
               '<a href="Problem/Delete">Удалить</a>'+
                '<a href="Problem/Description">Подробнее</a>' +
                '<a href="Problem/CreateSubProblem">Добавить подзадачу</a>'+
               '</div >' ;
        }
    }
})();
//для вывода описания
//var toDoItems = document.getElementsByClassName(".ProblemTitle")
//Array.from(toDoItems).forEach(toDo => toDo.addEventListener("click", async function ajaxDescription() {
//    jsonInput = toDo.parentElement.querySelector(".ProblemId").getAttribute("value")
//    $.ajax({
//        type: "GET",
//        url: "Problem/GetDescription",
//        dataType: "html",
//        data: {
//            jsonInput
//        },
//        success: function (data) {
//            $('.column.middle').empty()
//            $('.column.middle').append(data)
//        }
//    })
//}))
