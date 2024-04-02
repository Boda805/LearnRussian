module.exports = {
  content: ['./**/*.{razor,html}'],
  darkMode: 'class',
  theme: {
    extend: {
      colors: {
        'leather': '#964B00',
        'warm-beige': '#F5F5DC',
      },
      screens: {
        'se': {'max': '375px'},
        'tall': {
          'raw': `only screen and (max-height: 960px) and (max-width: 480px)`
        },
        'wide': {
          'raw': `only screen and (max-height: 480px) and (max-width: 960px)`
        },
        'landscape': {
          'raw': '(orientation: landscape)'
        }
      }
    },
  },
  plugins: [],
}