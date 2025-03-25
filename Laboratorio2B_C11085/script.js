function agregar(){
    let lista = document.getElementById("lista");
    let nuevo = document.createElement("li");
    let num = document.getElementsByTagName("li").length;
    num +=1;
    nuevo.textContent = "Elemento" + num;
    lista.appendChild(nuevo);
}
function cambiarFondo(){
    
    if (document.body.style.backgroundColor == "red"){
        document.body.style.backgroundColor = "white";
    }else{
       document.body.style.backgroundColor = "red";
}  
 }
   function borrar(){
    let lista = document.getElementById("lista");
    let num = document.getElementsByTagName("li").length;
    num -=1;
    let ultimo = document.getElementsByTagName("li")[num];
    lista.removeChild(ultimo);
}