﻿
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/





using UnityEngine;
using System.Collections;

namespace AppAdvisory.StopTheLock
{
	public class MonoBehaviourHelper : MonoBehaviour 
	{
		private Player _player;
		public Player player
		{
			get
			{
				if (_player == null)
					_player = FindObjectOfType<Player> ();

				return _player;
			}
		}

		private DotPosition _dotPosition;
		public DotPosition dotPosition
		{
			get
			{
				if (_dotPosition == null)
					_dotPosition = FindObjectOfType<DotPosition> ();

				return _dotPosition;
			}
		}

		private GameManager _gameManager;
		public GameManager gameManager
		{
			get
			{
				if (_gameManager == null)
					_gameManager = FindObjectOfType<GameManager> ();

				return _gameManager;
			}
		}

		private SoundManager _soundManager;
		public SoundManager soundManager
		{
			get
			{
				if (_soundManager == null)
					_soundManager = FindObjectOfType<SoundManager> ();

				return _soundManager;
			}
		}

		private ColorManager _colorManager;
		public ColorManager colorManager
		{
			get
			{
				if (_colorManager == null)
					_colorManager = FindObjectOfType<ColorManager> ();

				return _colorManager;
			}
		}
	}
}