# test for WebSocket connection
in browser:
	let connection;
	connection = new WebSocket("ws://localhost:8765");
	connection.onmessage = console.log;
	connection.sent("sup");


in Python:
import asyncio
from websockets.server import serve

async def echo(websocket):
    async for message in websocket:
        await websocket.send(message)

async def main():
    async with serve(echo, "localhost", 8765):
        await asyncio.Future()  # run forever






Links:
	https://websockets.readthedocs.io/en/stable/
	https://www.youtube.com/watch?v=wP8iUpM5DHU&list=PLtPJ9lKvJ4oiNMvYbOzCmWy6cRzYAh9B1&index=36
	https://www.youtube.com/watch?v=5tBmkxpeTyE