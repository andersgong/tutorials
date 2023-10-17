// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <string>
using namespace std;

DWORD WINAPI TestThread(LPVOID);
extern "C" __declspec(dllexport) void TestExport();
bool g_bStart = false;

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     ) {
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        CreateThread(NULL, NULL, &TestThread, NULL, NULL, NULL);
        break;
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

extern "C" __declspec(dllexport) void TestExport() {
    g_bStart = true;
}

DWORD WINAPI TestThread(LPVOID) {
    while (true) {
        Sleep(5000);
        if (!g_bStart) continue;
        typedef void(__cdecl* _exeChatScript)(const char* szScript);
        DWORD dwGBaseAddr = reinterpret_cast<DWORD>(GetModuleHandleA("Game.exe"));
        if (dwGBaseAddr == 0) continue;
        _exeChatScript exeChatScript = (_exeChatScript)(dwGBaseAddr + 0x140c0);
        string szScript1 = "Chat('CH_NEARBY','MuaÙB¸nÙ§åÙ§¬nÙGi¶n')";
        exeChatScript(szScript1.c_str());
        Sleep(100);
        string szScript2 = "Chat('CH_CITY','MuaÙB¸nÙ§åÙ§¬nÙGi¶n')";
        exeChatScript(szScript2.c_str());
        Sleep(100);
        string szScript3 = "Chat('CH_WORLD','MuaÙB¸nÙ§åÙ§¬nÙGi¶n')";
        exeChatScript(szScript3.c_str());
    }
    return 0;
}