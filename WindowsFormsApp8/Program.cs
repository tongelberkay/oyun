using Oyuncu;
using SFMLResim;
namespace mainclass
{

	public static class Program
	{
		public static void Main()
		{

			float x = 400, y = 400, r = 25;
			Resim.Yeni(800, 600, "oyun");
			Resim.SetFPSLimit(60);


			int bgResim = Resim.Ekle("res\\bg.png");
			int laser = Resim.Ekle("res\\laser_beam.png");
			while (Resim.Acik())
			{
				Resim.Baslat();

				Resim.Ciz(bgResim, 0, 0, 800, 600);
				Resim.Ciz(Karakter.Oyuncu(), x - r, y - r, 2 * r, 2 * r);
				Karakter.CharKontrol(ref y, ref x);
				//Karakter.Ates(laser,ref x,ref y);
				Resim.YaziYaz("FPS:" + (int)(1.0 / Resim.FrameTime), 0, 0, 50);
				Resim.Bitir();

			}

		}
	}
}
