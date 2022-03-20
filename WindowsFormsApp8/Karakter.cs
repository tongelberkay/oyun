using SFMLResim;

namespace Oyuncu
{

	public static class Karakter
	{
		public static void CharKontrol(ref float a, ref float b)
		{
			if (Resim.KlavyeBasili(Resim.Klavye.W))
				a -= 200 * Resim.FrameTime;
			else if (Resim.KlavyeBasili(Resim.Klavye.S))
				a += 200 * Resim.FrameTime;
			else if (Resim.KlavyeBasili(Resim.Klavye.A))
				b -= 200 * Resim.FrameTime;
			else if (Resim.KlavyeBasili(Resim.Klavye.D))
				b += 200 * Resim.FrameTime;
		}
		public static int Oyuncu()
		{
			return Resim.Ekle("res\\player.png");

		}
		/*public static void Ates(int res,ref float x, ref float y)
		{ 
			if(Resim.KlavyeBasili(Resim.Klavye.Space))
			{
				Resim.Ciz(res, x, y+76, 50, 50);

				y += 10 * Resim.FrameTime;
				
			}
		}*/
	}
}