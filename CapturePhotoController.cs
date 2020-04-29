using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// bu scripti CaptureAndSave objesinin içine ekleyin
// buttonun içindeki onClick Fonksioyonunun içine liste oluşturun ve CaptureAndSave objesini içine yerleştirin. Sonra no function denen yere tiklayın ve scriptin adı yazan yerin üzerine gelip fotocek fonksiyonunu seçiyoruz.
public class CapturePhotoController : MonoBehaviour
{
    public CaptureAndSave captureandsave; // buraya CaptureAndSave paketini ekle
    public GameObject uıgameobj; // buraya screenshot alacak butonun içinde bulunduğu canvas ı ekle
    private void OnEnable() {
        CaptureAndSaveEventListener.onSuccess += basarilicekim;
        CaptureAndSaveEventListener.onError += basarisizcekim;
    }

    private void OnDisable() {
        CaptureAndSaveEventListener.onSuccess -= basarilicekim;
        CaptureAndSaveEventListener.onError -= basarisizcekim;
    }
    public void fotocek() {
        uıgameobj.SetActive(false);
        captureandsave.CaptureAndSaveToAlbum();
    }
    //basarilicekim
    private void basarilicekim(string mesaj) {
        // buraya başarılı diye toast oluşturabilirsiniz ama bunun için permission ayarlamalarını yapmanız gerekir aksi taktirde basarisizcekim fonksiyonu çalışır.
        // toast için Asset Store dan Android Native Functions indirebilirsiniz 
        uıgameobj.SetActive(true);
    }
    //basarisizcekim
    private void basarisizcekim(string mesaj) {
        // buraya da başarısız diye toast oluşturabilirsiniz.
        uıgameobj.SetActive(true);
    }
}