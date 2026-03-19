const API = "http://localhost:5116/api/house";

async function loadHouses(){

const res = await fetch(API);

const data = await res.json();

const container = document.getElementById("houses");

container.innerHTML="";

data.forEach(h=>{

container.innerHTML+=`
<div class="house">

<img src="${h.imageUrl}">

<h3>${h.title}</h3>

<p>${h.location}</p>

<b>$${h.price}</b>

</div>
`;

});

}

async function addHouse(){

const house = {

title:document.getElementById("title").value,

location:document.getElementById("location").value,

price:parseInt(document.getElementById("price").value),

imageUrl:document.getElementById("image").value

};

await fetch(API,{
method:"POST",
headers:{
"Content-Type":"application/json"
},
body:JSON.stringify(house)
});

loadHouses();

}

loadHouses();