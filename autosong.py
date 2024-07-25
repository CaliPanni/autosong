import time
import pygetwindow as gw
import os

def get_vlc_window_title():
    windows = gw.getWindowsWithTitle('Lettore multimediale VLC')
    if windows:
        return windows[0].title
    return None


last_title = None

try:
    while True:
        current_title = get_vlc_window_title()
        curplay = current_title.replace(" - Lettore multimediale VLC", "").strip()
        if curplay and curplay != last_title and curplay != "Lettore multimediale VLC":
            os.system('cls')
            print(f'Now playing: {curplay}')
            last_title = curplay
            with open("song.txt", 'w') as file:
                file.write(curplay)
except KeyboardInterrupt:
    print("Interruzione del programma da tastiera.")
except Exception as e:
    print(f"Si è verificato un errore: {e}")
