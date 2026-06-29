using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwait3 : MonoBehaviour
{
    string filePath;
    string fileContents;

    private void Start()
    {
        // (Application.dataPath = Assets 폴더 경로
        filePath = Path.Combine(Application.dataPath, "Recources/File.txt");

        Task task = new Task(() =>
        {
            Debug.Log("동기 실행");
            ReadFile();
        });

        task.Start();
        Debug.Log("메인스레드 진행 중");

        task.Wait();
        Debug.Log("파일 읽기 완료 : " + fileContents);
    }

    void ReadFile()
    {
        if(File.Exists(filePath)) fileContents = File.ReadAllText(filePath);
    }
}
