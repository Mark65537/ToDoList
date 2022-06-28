////(function () {
////    var ul = document.querySelectorAll('.ProblemTitle');
////    for (var i = 0; i < ul.length; i++) {
////        var span = document.createElement('span');
////        span.className = 'drop';
////        span.innerHTML = '+'; // картинки лучше выравниваются, т.к. символы на одном браузере ровно выглядят, на другом — чуть съезжают 
////        ul[i].parentNode.insertBefore(span, ul[i]);
////        span.onclick = function () {
////            this.innerHTML = (this.innerHTML == '+' ? '−' : '+');
////            this.className = (this.className == 'drop' ? 'drop dropM' : 'drop');
////        }
////    }
////})();

$(document).ready(function () {
    $('.drop').click(function (e) {
        e.preventDefault();
        this.innerHTML = (this.innerHTML == '+' ? '−' : '+');
        this.className = (this.className == 'drop' ? 'drop dropM' : 'drop');
        var id = this.parentElement.querySelector(".ProblemId").getAttribute("value")
        //console.log($(this).find(".SubProblemContainer"))
        if (this.innerHTML == '−') {
            $(this).next().next().load('Problem/GetSubProblems?id=' + id)
            //$(this).next().next().click(function (e) {
            //    e.preventDefault();
            //    var id = this.parentElement.querySelector(".ProblemId").getAttribute("value")
            //    //id = encodeURIComponent(id);
            //    $('.description').load('Problem/GetDescription?id=' + id)
            //});
        }        
    });
});
//(function () {
//    var pt = document.querySelectorAll(".ProblemTitle");
//    for (var i = 0; i < pt.length; i++) {
//        var title = pt[i].innerHTML;
//        pt[i].onclick = function () {
//            document.getElementById("description").innerHTML = title + '<div>'+
//               '<a href="Problem/Update">Изменить</a>'+
//               '<a href="Problem/Delete">Удалить</a>'+
//                '<a href="Problem/Description">Подробнее</a>' +
//                '<a href="Problem/CreateSubProblem">Добавить подзадачу</a>'+
//               '</div >' ;
//        }
//    }
//})();
//для вывода описания
//var toDoItems = document.getElementsByClassName("ProblemTitle")
////jsonInput = toDoItems[0].parentElement.querySelector(".ProblemId").getAttribute("value")
//Array.from(toDoItems).forEach(toDo => toDo.addEventListener("click", async function ajaxDescription() {
//    //jsonInput = toDo.parentElement.querySelector(".ProblemId").getAttribute("value")
//    $.ajax({
//        type: "GET",
//        url: "Problem/GetDescription",
//        dataType: "html",
//        data: {
//            //jsonInput
//        },
//        //success: function (data) {
//        //    $('.description').empty()
//        //    $('.description').append(data)
//        //}
//    })
//}))
$(document).find('.ProblemTitle').click(function(e){
    $('.description').append("halo");
})
$('.ProblemTitle').on('mouseover', '.description', function () {
    $('.description').append("halo");
});
//$('.ProblemTitle').on(function (e) {
//    e.preventDefault();
//    var id = this.parentElement.querySelector(".ProblemId").getAttribute("value")
//    //id = encodeURIComponent(id);
//    $('.description').load('Problem/GetDescription?id=' + id)
//});

$(document).ready(function () {
    $('.ProblemTitle').click(function (e) {
        e.preventDefault();
        var id=this.parentElement.querySelector(".ProblemId").getAttribute("value")
        //id = encodeURIComponent(id);
        $('.description').load('Problem/GetDescription?id=' + id)
    });
});