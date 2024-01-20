import subprocess
import shutil
import os
import zipfile
import threading

print('Cleaning up build directory')

shutil.rmtree('../Builds', ignore_errors=True)

print('Starting build process')

unity_path = '/Applications/Unity/Hub/Editor/2022.3.2f1/Unity.app/Contents/MacOS/Unity'
project_path = os.getcwd()
print(project_path)
print("")
subprocess.run([unity_path, "-projectPath", project_path, "-executeMethod", "XenoBuildScript.StartBuild"])

print('Build process ended')

#def zipdir(path):
#    ziph = zipfile.ZipFile(f'{os.path.basename(path)}.zip', 'w', zipfile.ZIP_DEFLATED)
#    for root, dirs, files in os.walk(path):
#        for file in files:
#            ziph.write(os.path.join(root, file))


#print('Zipping Builds')
#zipdir('Builds/Windows')
#zipdir('Builds/Linux')
#zipdir('Builds/Web GL')
#zipdir('Builds/MacOSX.app')
#print('Zipping Complete')