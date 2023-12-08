const video = document.querySelector('.video');
const botaoCamera = document.querySelector('.botaoCamera');
const canvas = document.querySelector('.canvas');
const fotoContainer = document.querySelector('.fotos');

//Array de fotos
const fotos = [];

//Solicitando permissão para acessar a camera
navigator.mediaDevices.getUserMedia({video : true})
        .then(stream => {
            video.srcObject = stream;
            video.play();
        })
        .catch(error => {
            console.log(error);
        })

botaoCamera.addEventListener('click', () => {
    canvas.getContext('2d').drawImage(video,0,0,
        canvas.width, canvas.height);
        //definio caminho para imagem
        let urlImagem = canvas.toDataURL('imagem/jpeg');

        //Cria elemento de imagem para exibir a foto
        const foto = document.createElement('img');
        foto.src = urlImagem;
        foto.className = 'foto';
        fotoContainer.innerHTML = '';
        fotoContainer.appendChild(foto);

        //Adicionar a foto ao arry de fotos
        fotos.push(urlImagem);

        //adicione um ouvinte de eventos para download
        foto.addEventListener('click', () => {
            downloadImagem(urlImagem);
        })
})

//Função para download da imagem
function downloadImagem(dataUrl){
    const a = document.createElement('a');
    a.href = dataUrl;
    a.download = 'foto.jpg';
    a.style.display = 'none';
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
}