module.exports = {
  content: ['./**/*.{razor,html}'],
  darkMode: 'class',
  theme: {
    extend: {
      screens: {
        'tall': {
          'raw': `only screen and (max-height: 960px) and (max-width: 480px)`
        },
        'wide': {
          'raw': `only screen and (max-height: 480px) and (max-width: 960px)`
        }
      }
    },
  },
  plugins: [],
}