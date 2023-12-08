if ('geolocation' in navigator){
    navigator.geolocation.getCurrentPosition(function (position){
        //obtem as coordenadas de latitude  e longitude
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;

        //Atualiza os elementos HTML com as coordenadas
        document.querySelector('#latitude').textContent = latitude;
        document.querySelector('#longitude').textContent = longitude;

        //Cria um mapa Leaflet com as coordenadas de geolocalização
        var map = L.map('map').setView([latitude, longitude], 15);

        //Adiciona camadas de mapa a partir do OpenStreeMap
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
        }).addTo(map);

        //Adicina um marcador
        L.marker([latitude, longitude]).addTo(map)
                .bindPopup("Sua localização Atual")
                .openPopup();
    })
}
else {
    //não suporta geolocalizacao
    alert("Geolocalizacao não é suportada pelo navegador");
}