using System.IO;
using System.Threading.Tasks;
using UnityEngine;

// async await 비동기 사용 방법
// using System.Threading.Tasks; 선언
// 비동기로 실행할 메서드 앞에 async 키워드 넣기
// 비동기로 실행할 부분 앞에 await 넣기

// async 메서드의 반환 타입은 일반적으로 Task, Task<TResult>
// void도 허용 -> eventHandler를 위해서 

public class AsyncAwait5 : MonoBehaviour
{
    string filePath;
    string fileContents;

    async void Start()
    {
        // (Application.dataPath = Assets 폴더 경로
        filePath = Path.Combine(Application.dataPath, "Recources/File.txt");

        // 비동기 파일 읽기 시작
        fileContents = await ReadFileAsync(filePath);

        // 비동기 작업 완료 후 결과 출력
        Debug.Log("파일 읽기 완료 : " + fileContents);
    }

    async Task<string> ReadFileAsync(string path)
    {
        if (File.Exists(path))
        {
            return await Task.Run(() => File.ReadAllText(path));
        }

        return null;
    }
}
