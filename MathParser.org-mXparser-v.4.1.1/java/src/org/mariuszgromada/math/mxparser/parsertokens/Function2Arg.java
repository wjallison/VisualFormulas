/*
 * @(#)Function2Arg.java        4.1.0    2017-05-13
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2017 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
package org.mariuszgromada.math.mxparser.parsertokens;

import org.mariuszgromada.math.mxparser.mXparser;
/**
 * Binary functions (2 arguments) - mXparser tokens definition.
 *
 * @author         <b>Mariusz Gromada</b><br>
 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
 *
 * @version        4.1.0
 */
public final class Function2Arg {
	/*
	 * BinaryFunction - token type id.
	 */
	public static final int TYPE_ID 							= 5;
	public static final String TYPE_DESC						= "Binary Function";
	/*
	 * BinaryFunction - tokens id.
	 */
	public static final int LOG_ID 								= 1;
	public static final int MOD_ID								= 2;
	public static final int BINOM_COEFF_ID						= 3;
	public static final int BERNOULLI_NUMBER_ID					= 4;
	public static final int STIRLING1_NUMBER_ID					= 5;
	public static final int STIRLING2_NUMBER_ID					= 6;
	public static final int WORPITZKY_NUMBER_ID					= 7;
	public static final int EULER_NUMBER_ID						= 8;
	public static final int KRONECKER_DELTA_ID					= 9;
	public static final int EULER_POLYNOMIAL_ID					= 10;
	public static final int HARMONIC_NUMBER_ID					= 11;
	public static final int RND_UNIFORM_CONT_ID					= 12;
	public static final int RND_UNIFORM_DISCR_ID				= 13;
	public static final int ROUND_ID							= 14;
	public static final int RND_NORMAL_ID						= 15;
	public static final int NDIG_ID								= 16;
	public static final int DIGIT10_ID							= 17;
	public static final int FACTVAL_ID							= 18;
	public static final int FACTEXP_ID							= 19;
	public static final int ROOT_ID								= 20;
	/*
	 * BinaryFunction - tokens key words.
	 */
	public static final String LOG_STR 							= "log";
	public static final String MOD_STR 							= "mod";
	public static final String BINOM_COEFF_STR					= "C";
	public static final String BERNOULLI_NUMBER_STR				= "Bern";
	public static final String STIRLING1_NUMBER_STR				= "Stirl1";
	public static final String STIRLING2_NUMBER_STR				= "Stirl2";
	public static final String WORPITZKY_NUMBER_STR				= "Worp";
	public static final String EULER_NUMBER_STR					= "Euler";
	public static final String KRONECKER_DELTA_STR				= "KDelta";
	public static final String EULER_POLYNOMIAL_STR				= "EulerPol";
	public static final String HARMONIC_NUMBER_STR				= "Harm";
	public static final String RND_UNIFORM_CONT_STR 			= "rUni";
	public static final String RND_UNIFORM_DISCR_STR  			= "rUnid";
	public static final String ROUND_STR						= "round";
	public static final String RND_NORMAL_STR					= "rNor";
	public static final String NDIG_STR							= "ndig";
	public static final String DIGIT10_STR						= "dig10";
	public static final String FACTVAL_STR						= "factval";
	public static final String FACTEXP_STR						= "factexp";
	public static final String ROOT_STR						= "root";
	/*
	 * BinaryFunction - syntax.
	 */
	public static final String LOG_SYN 							= "log(a, b)";
	public static final String MOD_SYN 							= "mod(a, b)";
	public static final String BINOM_COEFF_SYN					= "C(n, k)";
	public static final String BERNOULLI_NUMBER_SYN				= "Bern(m, n)";
	public static final String STIRLING1_NUMBER_SYN				= "Stirl1(n, k)";
	public static final String STIRLING2_NUMBER_SYN				= "Stirl2(n, k)";
	public static final String WORPITZKY_NUMBER_SYN				= "Worp(n, k)";
	public static final String EULER_NUMBER_SYN					= "Euler(n, k)";
	public static final String KRONECKER_DELTA_SYN				= "KDelta(i, j)";
	public static final String EULER_POLYNOMIAL_SYN				= "EulerPol";
	public static final String HARMONIC_NUMBER_SYN				= "Harm(x, n)";
	public static final String RND_UNIFORM_CONT_SYN 			= "rUni(a, b)";
	public static final String RND_UNIFORM_DISCR_SYN  			= "rUnid(a, b)";
	public static final String ROUND_SYN						= "round(x, n)";
	public static final String RND_NORMAL_SYN					= "rNor(mean, stdv)";
	public static final String NDIG_SYN							= "ndig(number, base)";
	public static final String DIGIT10_SYN						= "dig10(num, pos)";
	public static final String FACTVAL_SYN						= "factval(number, factorid)";
	public static final String FACTEXP_SYN						= "factexp(number, factorid)";
	public static final String ROOT_SYN							= "root(rootorder, number)";
	/*
	 * BinaryFunction - tokens description.
	 */
	public static final String LOG_DESC 						= "Logarithm function";
	public static final String MOD_DESC							= "Modulo function";
	public static final String BINOM_COEFF_DESC					= "Binomial coefficient function";
	public static final String BERNOULLI_NUMBER_DESC			= "Bernoulli numbers";
	public static final String STIRLING1_NUMBER_DESC			= "Stirling numbers of the first kind";
	public static final String STIRLING2_NUMBER_DESC			= "Stirling numbers of the second kind";
	public static final String WORPITZKY_NUMBER_DESC			= "Worpitzky number";
	public static final String EULER_NUMBER_DESC				= "Euler number";
	public static final String KRONECKER_DELTA_DESC				= "Kronecker delta";
	public static final String EULER_POLYNOMIAL_DESC			= "EulerPol";
	public static final String HARMONIC_NUMBER_DESC				= "Harmonic number";
	public static final String RND_UNIFORM_CONT_DESC 			= "Random variable - Uniform continuous distribution U(a,b), usage example: 2*rUni(2,10)";
	public static final String RND_UNIFORM_DISCR_DESC  			= "Random variable - Uniform discrete distribution U{a,b}, usage example: 2*rUnid(2,100)";
	public static final String ROUND_DESC						= "Half-up rounding, usage examples: round(2.2, 0) = 2, round(2.6, 0) = 3, round(2.66,1) = 2.7";
	public static final String RND_NORMAL_DESC					= "Random variable - Normal distribution N(m,s) m - mean, s - stddev, usage example: 3*rNor(0,1)";
	public static final String NDIG_DESC						= "Number of digits representing the number in numeral system with given base";
	public static final String DIGIT10_DESC						= "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - base 10 numeral system";
	public static final String FACTVAL_DESC						= "Prime decomposition - factor value at position between 1 ... nfact(n) - ascending order by factor value";
	public static final String FACTEXP_DESC						= "Prime decomposition - factor exponent / multiplicity at position between 1 ... nfact(n) - ascending order by factor value";
	public static final String ROOT_DESC						= "N-th order root of a number";
	/*
	 * BinaryFunction - since.
	 */
	public static final String LOG_SINCE 						= mXparser.NAMEv10;
	public static final String MOD_SINCE						= mXparser.NAMEv10;
	public static final String BINOM_COEFF_SINCE				= mXparser.NAMEv10;
	public static final String BERNOULLI_NUMBER_SINCE			= mXparser.NAMEv10;
	public static final String STIRLING1_NUMBER_SINCE			= mXparser.NAMEv10;
	public static final String STIRLING2_NUMBER_SINCE			= mXparser.NAMEv10;
	public static final String WORPITZKY_NUMBER_SINCE			= mXparser.NAMEv10;
	public static final String EULER_NUMBER_SINCE				= mXparser.NAMEv10;
	public static final String KRONECKER_DELTA_SINCE			= mXparser.NAMEv10;
	public static final String EULER_POLYNOMIAL_SINCE			= mXparser.NAMEv10;
	public static final String HARMONIC_NUMBER_SINCE			= mXparser.NAMEv10;
	public static final String RND_UNIFORM_CONT_SINCE 			= mXparser.NAMEv30;
	public static final String RND_UNIFORM_DISCR_SINCE  		= mXparser.NAMEv30;
	public static final String ROUND_SINCE						= mXparser.NAMEv30;
	public static final String RND_NORMAL_SINCE					= mXparser.NAMEv30;
	public static final String NDIG_SINCE						= mXparser.NAMEv41;
	public static final String DIGIT10_SINCE					= mXparser.NAMEv41;
	public static final String FACTVAL_SINCE					= mXparser.NAMEv41;
	public static final String FACTEXP_SINCE					= mXparser.NAMEv41;
	public static final String ROOT_SINCE						= mXparser.NAMEv41;
}

