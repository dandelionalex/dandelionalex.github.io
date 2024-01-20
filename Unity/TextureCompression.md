# Texture Compression

Different compression formats have diffrerent bits per pixel (bpp).


Compression types:
ETC2 - Android

ASTC - modern iOS
PVRTC - support very old iOS device

DXT - Desktop
BC1 - Desktop



https://www.techarthub.com/an-introduction-to-texture-compression-in-unity/
https://docs.unity3d.com/2020.1/Documentation/Manual/class-TextureImporterOverride.html

https://youtu.be/80_moZWyybA?si=UoQFPJu2flugqlX- texture compression in Unity
https://youtu.be/3H-HGlsC0NY?si=D3n3n-OqqoPpQK69 image compression to GPU in general

GPU friendly compression
Reduse amount of data in DrawCall
Random Access


actual texture format can be printed in log -> speakerIconSprite.texture.format