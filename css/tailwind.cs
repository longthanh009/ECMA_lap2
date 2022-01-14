/*
! tailwindcss v3.0.10 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: currentColor;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input:-ms-input-placeholder, textarea:-ms-input-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/*
Ensure the default browser behavior of the `hidden` attribute.
*/

[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-opacity: 1;
  border-color: rgb(229 231 235 / var(--tw-border-opacity));
  --tw-ring-inset: var(--tw-empty,/*!*/ /*!*/);
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
}

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  white-space: nowrap;
  border-width: 0;
}

.absolute {
  position: absolute;
}

.relative {
  position: relative;
}

.inset-0 {
  top: 0px;
  right: 0px;
  bottom: 0px;
  left: 0px;
}

.inset-y-0 {
  top: 0px;
  bottom: 0px;
}

.left-0 {
  left: 0px;
}

.col-span-6 {
  grid-column: span 6 / span 6;
}

.mx-auto {
  margin-left: auto;
  margin-right: auto;
}

.mx-5 {
  margin-left: 1.25rem;
  margin-right: 1.25rem;
}

.-mx-4 {
  margin-left: -1rem;
  margin-right: -1rem;
}

.ml-10 {
  margin-left: 2.5rem;
}

.ml-4 {
  margin-left: 1rem;
}

.-mr-2 {
  margin-right: -0.5rem;
}

.ml-3 {
  margin-left: 0.75rem;
}

.ml-auto {
  margin-left: auto;
}

.mt-\[10px\] {
  margin-top: 10px;
}

.mr-2 {
  margin-right: 0.5rem;
}

.mr-\[10px\] {
  margin-right: 10px;
}

.mb-5 {
  margin-bottom: 1.25rem;
}

.mt-1 {
  margin-top: 0.25rem;
}

.ml-1 {
  margin-left: 0.25rem;
}

.mt-6 {
  margin-top: 1.5rem;
}

.mt-8 {
  margin-top: 2rem;
}

.ml-2 {
  margin-left: 0.5rem;
}

.mt-5 {
  margin-top: 1.25rem;
}

.mt-2 {
  margin-top: 0.5rem;
}

.block {
  display: block;
}

.inline-block {
  display: inline-block;
}

.flex {
  display: flex;
}

.inline-flex {
  display: inline-flex;
}

.table {
  display: table;
}

.grid {
  display: grid;
}

.hidden {
  display: none;
}

.h-16 {
  height: 4rem;
}

.h-8 {
  height: 2rem;
}

.h-6 {
  height: 1.5rem;
}

.h-10 {
  height: 2.5rem;
}

.h-\[25px\] {
  height: 25px;
}

.h-4 {
  height: 1rem;
}

.h-12 {
  height: 3rem;
}

.h-5 {
  height: 1.25rem;
}

.h-full {
  height: 100%;
}

.min-h-screen {
  min-height: 100vh;
}

.min-h-full {
  min-height: 100%;
}

.w-\[1200px\] {
  width: 1200px;
}

.w-8 {
  width: 2rem;
}

.w-6 {
  width: 1.5rem;
}

.w-10 {
  width: 2.5rem;
}

.w-full {
  width: 100%;
}

.w-\[20\%\] {
  width: 20%;
}

.w-2\/3 {
  width: 66.666667%;
}

.w-1\/2 {
  width: 50%;
}

.w-\[200px\] {
  width: 200px;
}

.w-4 {
  width: 1rem;
}

.w-auto {
  width: auto;
}

.w-5 {
  width: 1.25rem;
}

.min-w-full {
  min-width: 100%;
}

.max-w-7xl {
  max-width: 80rem;
}

.max-w-md {
  max-width: 28rem;
}

.flex-shrink-0 {
  flex-shrink: 0;
}

.cursor-pointer {
  cursor: pointer;
}

.appearance-none {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.grid-cols-3 {
  grid-template-columns: repeat(3, minmax(0, 1fr));
}

.grid-cols-2 {
  grid-template-columns: repeat(2, minmax(0, 1fr));
}

.grid-cols-6 {
  grid-template-columns: repeat(6, minmax(0, 1fr));
}

.flex-col {
  flex-direction: column;
}

.items-center {
  align-items: center;
}

.items-baseline {
  align-items: baseline;
}

.justify-center {
  justify-content: center;
}

.justify-between {
  justify-content: space-between;
}

.justify-around {
  justify-content: space-around;
}

.gap-5 {
  gap: 1.25rem;
}

.gap-1 {
  gap: 0.25rem;
}

.gap-6 {
  gap: 1.5rem;
}

.space-x-4 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 0;
  margin-right: calc(1rem * var(--tw-space-x-reverse));
  margin-left: calc(1rem * calc(1 - var(--tw-space-x-reverse)));
}

.space-y-1 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(0.25rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(0.25rem * var(--tw-space-y-reverse));
}

.space-y-8 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(2rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(2rem * var(--tw-space-y-reverse));
}

.space-y-6 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(1.5rem * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(1.5rem * var(--tw-space-y-reverse));
}

.-space-y-px > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 0;
  margin-top: calc(-1px * calc(1 - var(--tw-space-y-reverse)));
  margin-bottom: calc(-1px * var(--tw-space-y-reverse));
}

.space-x-8 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 0;
  margin-right: calc(2rem * var(--tw-space-x-reverse));
  margin-left: calc(2rem * calc(1 - var(--tw-space-x-reverse)));
}

.divide-y > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-y-reverse: 0;
  border-top-width: calc(1px * calc(1 - var(--tw-divide-y-reverse)));
  border-bottom-width: calc(1px * var(--tw-divide-y-reverse));
}

.divide-gray-200 > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-opacity: 1;
  border-color: rgb(229 231 235 / var(--tw-divide-opacity));
}

.overflow-hidden {
  overflow: hidden;
}

.overflow-x-auto {
  overflow-x: auto;
}

.whitespace-nowrap {
  white-space: nowrap;
}

.rounded-md {
  border-radius: 0.375rem;
}

.rounded-full {
  border-radius: 9999px;
}

.rounded-lg {
  border-radius: 0.5rem;
}

.rounded {
  border-radius: 0.25rem;
}

.rounded-l {
  border-top-left-radius: 0.25rem;
  border-bottom-left-radius: 0.25rem;
}

.rounded-r {
  border-top-right-radius: 0.25rem;
  border-bottom-right-radius: 0.25rem;
}

.border-\[2px\] {
  border-width: 2px;
}

.border-\[1px\] {
  border-width: 1px;
}

.border {
  border-width: 1px;
}

.border-t {
  border-top-width: 1px;
}

.border-b-2 {
  border-bottom-width: 2px;
}

.border-b {
  border-bottom-width: 1px;
}

.border-solid {
  border-style: solid;
}

.border-gray-700 {
  --tw-border-opacity: 1;
  border-color: rgb(55 65 81 / var(--tw-border-opacity));
}

.border-white {
  --tw-border-opacity: 1;
  border-color: rgb(255 255 255 / var(--tw-border-opacity));
}

.border-\[\#ccc\] {
  --tw-border-opacity: 1;
  border-color: rgb(204 204 204 / var(--tw-border-opacity));
}

.border-gray-200 {
  --tw-border-opacity: 1;
  border-color: rgb(229 231 235 / var(--tw-border-opacity));
}

.border-gray-300 {
  --tw-border-opacity: 1;
  border-color: rgb(209 213 219 / var(--tw-border-opacity));
}

.border-transparent {
  border-color: transparent;
}

.bg-gray-800 {
  --tw-bg-opacity: 1;
  background-color: rgb(31 41 55 / var(--tw-bg-opacity));
}

.bg-gray-900 {
  --tw-bg-opacity: 1;
  background-color: rgb(17 24 39 / var(--tw-bg-opacity));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-blue-900 {
  --tw-bg-opacity: 1;
  background-color: rgb(30 58 138 / var(--tw-bg-opacity));
}

.bg-orange-400 {
  --tw-bg-opacity: 1;
  background-color: rgb(251 146 60 / var(--tw-bg-opacity));
}

.bg-blue-800 {
  --tw-bg-opacity: 1;
  background-color: rgb(30 64 175 / var(--tw-bg-opacity));
}

.bg-gray-100 {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}

.bg-blue-500 {
  --tw-bg-opacity: 1;
  background-color: rgb(59 130 246 / var(--tw-bg-opacity));
}

.bg-indigo-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(79 70 229 / var(--tw-bg-opacity));
}

.bg-gray-50 {
  --tw-bg-opacity: 1;
  background-color: rgb(249 250 251 / var(--tw-bg-opacity));
}

.bg-green-200 {
  --tw-bg-opacity: 1;
  background-color: rgb(187 247 208 / var(--tw-bg-opacity));
}

.bg-orange-200 {
  --tw-bg-opacity: 1;
  background-color: rgb(254 215 170 / var(--tw-bg-opacity));
}

.bg-red-200 {
  --tw-bg-opacity: 1;
  background-color: rgb(254 202 202 / var(--tw-bg-opacity));
}

.object-cover {
  -o-object-fit: cover;
     object-fit: cover;
}

.p-1 {
  padding: 0.25rem;
}

.p-2 {
  padding: 0.5rem;
}

.p-10 {
  padding: 2.5rem;
}

.p-5 {
  padding: 1.25rem;
}

.p-8 {
  padding: 2rem;
}

.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}

.px-3 {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.px-2 {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
}

.px-5 {
  padding-left: 1.25rem;
  padding-right: 1.25rem;
}

.py-6 {
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
}

.py-3 {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
}

.px-\[10px\] {
  padding-left: 10px;
  padding-right: 10px;
}

.py-\[20px\] {
  padding-top: 20px;
  padding-bottom: 20px;
}

.py-5 {
  padding-top: 1.25rem;
  padding-bottom: 1.25rem;
}

.py-7 {
  padding-top: 1.75rem;
  padding-bottom: 1.75rem;
}

.py-2\.5 {
  padding-top: 0.625rem;
  padding-bottom: 0.625rem;
}

.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}

.py-12 {
  padding-top: 3rem;
  padding-bottom: 3rem;
}

.py-1 {
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
}

.pt-2 {
  padding-top: 0.5rem;
}

.pb-3 {
  padding-bottom: 0.75rem;
}

.pt-4 {
  padding-top: 1rem;
}

.pt-\[10px\] {
  padding-top: 10px;
}

.pb-1 {
  padding-bottom: 0.25rem;
}

.pl-3 {
  padding-left: 0.75rem;
}

.pb-6 {
  padding-bottom: 1.5rem;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.text-right {
  text-align: right;
}

.align-text-top {
  vertical-align: text-top;
}

.align-text-bottom {
  vertical-align: text-bottom;
}

.text-sm {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.text-base {
  font-size: 1rem;
  line-height: 1.5rem;
}

.text-3xl {
  font-size: 1.875rem;
  line-height: 2.25rem;
}

.text-\[14px\] {
  font-size: 14px;
}

.text-\[20px\] {
  font-size: 20px;
}

.text-\[18px\] {
  font-size: 18px;
}

.text-2xl {
  font-size: 1.5rem;
  line-height: 2rem;
}

.text-xs {
  font-size: 0.75rem;
  line-height: 1rem;
}

.font-medium {
  font-weight: 500;
}

.font-bold {
  font-weight: 700;
}

.font-semibold {
  font-weight: 600;
}

.font-normal {
  font-weight: 400;
}

.font-extrabold {
  font-weight: 800;
}

.uppercase {
  text-transform: uppercase;
}

.leading-none {
  line-height: 1;
}

.leading-normal {
  line-height: 1.5;
}

.leading-tight {
  line-height: 1.25;
}

.tracking-wide {
  letter-spacing: 0.025em;
}

.tracking-wider {
  letter-spacing: 0.05em;
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.text-gray-300 {
  --tw-text-opacity: 1;
  color: rgb(209 213 219 / var(--tw-text-opacity));
}

.text-gray-400 {
  --tw-text-opacity: 1;
  color: rgb(156 163 175 / var(--tw-text-opacity));
}

.text-gray-900 {
  --tw-text-opacity: 1;
  color: rgb(17 24 39 / var(--tw-text-opacity));
}

.text-indigo-900 {
  --tw-text-opacity: 1;
  color: rgb(49 46 129 / var(--tw-text-opacity));
}

.text-orange-600 {
  --tw-text-opacity: 1;
  color: rgb(234 88 12 / var(--tw-text-opacity));
}

.text-gray-600 {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.text-gray-500 {
  --tw-text-opacity: 1;
  color: rgb(107 114 128 / var(--tw-text-opacity));
}

.text-indigo-600 {
  --tw-text-opacity: 1;
  color: rgb(79 70 229 / var(--tw-text-opacity));
}

.text-indigo-500 {
  --tw-text-opacity: 1;
  color: rgb(99 102 241 / var(--tw-text-opacity));
}

.text-gray-700 {
  --tw-text-opacity: 1;
  color: rgb(55 65 81 / var(--tw-text-opacity));
}

.text-green-900 {
  --tw-text-opacity: 1;
  color: rgb(20 83 45 / var(--tw-text-opacity));
}

.text-orange-900 {
  --tw-text-opacity: 1;
  color: rgb(124 45 18 / var(--tw-text-opacity));
}

.text-red-900 {
  --tw-text-opacity: 1;
  color: rgb(127 29 29 / var(--tw-text-opacity));
}

.text-indigo-50 {
  --tw-text-opacity: 1;
  color: rgb(238 242 255 / var(--tw-text-opacity));
}

.underline {
  -webkit-text-decoration-line: underline;
          text-decoration-line: underline;
}

.placeholder-gray-500::-moz-placeholder {
  --tw-placeholder-opacity: 1;
  color: rgb(107 114 128 / var(--tw-placeholder-opacity));
}

.placeholder-gray-500:-ms-input-placeholder {
  --tw-placeholder-opacity: 1;
  color: rgb(107 114 128 / var(--tw-placeholder-opacity));
}

.placeholder-gray-500::placeholder {
  --tw-placeholder-opacity: 1;
  color: rgb(107 114 128 / var(--tw-placeholder-opacity));
}

.opacity-50 {
  opacity: 0.5;
}

.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-sm {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.outline-none {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.ring-inset {
  --tw-ring-inset: inset;
}

.transition {
  transition-property: color, background-color, border-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-text-decoration-color, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-text-decoration-color, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.duration-200 {
  transition-duration: 200ms;
}

.duration-150 {
  transition-duration: 150ms;
}

.hover\:bg-gray-700:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(55 65 81 / var(--tw-bg-opacity));
}

.hover\:bg-blue-600:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(37 99 235 / var(--tw-bg-opacity));
}

.hover\:bg-gray-100:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}

.hover\:bg-gray-200:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(229 231 235 / var(--tw-bg-opacity));
}

.hover\:bg-indigo-700:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(67 56 202 / var(--tw-bg-opacity));
}

.hover\:bg-indigo-500:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(99 102 241 / var(--tw-bg-opacity));
}

.hover\:text-white:hover {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.hover\:text-orange-900:hover {
  --tw-text-opacity: 1;
  color: rgb(124 45 18 / var(--tw-text-opacity));
}

.hover\:text-indigo-500:hover {
  --tw-text-opacity: 1;
  color: rgb(99 102 241 / var(--tw-text-opacity));
}

.hover\:shadow-md:hover {
  --tw-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 4px 6px -1px var(--tw-shadow-color), 0 2px 4px -2px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.focus\:z-10:focus {
  z-index: 10;
}

.focus\:border-indigo-500:focus {
  --tw-border-opacity: 1;
  border-color: rgb(99 102 241 / var(--tw-border-opacity));
}

.focus\:bg-blue-700:focus {
  --tw-bg-opacity: 1;
  background-color: rgb(29 78 216 / var(--tw-bg-opacity));
}

.focus\:bg-gray-200:focus {
  --tw-bg-opacity: 1;
  background-color: rgb(229 231 235 / var(--tw-bg-opacity));
}

.focus\:bg-gray-300:focus {
  --tw-bg-opacity: 1;
  background-color: rgb(209 213 219 / var(--tw-bg-opacity));
}

.focus\:shadow-sm:focus {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.focus\:outline-none:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.focus\:ring-2:focus {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(2px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.focus\:ring-4:focus {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(4px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.focus\:ring-white:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(255 255 255 / var(--tw-ring-opacity));
}

.focus\:ring-blue-500:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(59 130 246 / var(--tw-ring-opacity));
}

.focus\:ring-gray-400:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(156 163 175 / var(--tw-ring-opacity));
}

.focus\:ring-indigo-500:focus {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(99 102 241 / var(--tw-ring-opacity));
}

.focus\:ring-opacity-50:focus {
  --tw-ring-opacity: 0.5;
}

.focus\:ring-offset-2:focus {
  --tw-ring-offset-width: 2px;
}

.focus\:ring-offset-gray-800:focus {
  --tw-ring-offset-color: #1f2937;
}

.group:hover .group-hover\:text-indigo-400 {
  --tw-text-opacity: 1;
  color: rgb(129 140 248 / var(--tw-text-opacity));
}

@media (min-width: 640px) {
  .sm\:col-span-3 {
    grid-column: span 3 / span 3;
  }

  .sm\:col-span-4 {
    grid-column: span 4 / span 4;
  }

  .sm\:col-span-6 {
    grid-column: span 6 / span 6;
  }

  .sm\:-mx-8 {
    margin-left: -2rem;
    margin-right: -2rem;
  }

  .sm\:rounded-md {
    border-radius: 0.375rem;
  }

  .sm\:p-6 {
    padding: 1.5rem;
  }

  .sm\:px-6 {
    padding-left: 1.5rem;
    padding-right: 1.5rem;
  }

  .sm\:px-3 {
    padding-left: 0.75rem;
    padding-right: 0.75rem;
  }

  .sm\:py-12 {
    padding-top: 3rem;
    padding-bottom: 3rem;
  }

  .sm\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .sm\:text-left {
    text-align: left;
  }

  .sm\:text-right {
    text-align: right;
  }

  .sm\:text-sm {
    font-size: 0.875rem;
    line-height: 1.25rem;
  }
}

@media (min-width: 768px) {
  .md\:col-span-2 {
    grid-column: span 2 / span 2;
  }

  .md\:ml-6 {
    margin-left: 1.5rem;
  }

  .md\:mt-0 {
    margin-top: 0px;
  }

  .md\:block {
    display: block;
  }

  .md\:hidden {
    display: none;
  }

  .md\:w-full {
    width: 100%;
  }

  .md\:max-w-md {
    max-width: 28rem;
  }
}

@media (min-width: 1024px) {
  .lg\:col-span-2 {
    grid-column: span 2 / span 2;
  }

  .lg\:ml-40 {
    margin-left: 10rem;
  }

  .lg\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }
}